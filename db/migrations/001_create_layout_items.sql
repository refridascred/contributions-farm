-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, score, ratio) VALUES ('open', 94.04, 89.44);
INSERT INTO layout_items (token, score, ratio) VALUES ('primary', 40.2, 82.88);
