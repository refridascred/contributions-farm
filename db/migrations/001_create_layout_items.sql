-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, weight, score, ratio) VALUES ('stable', 47.61, 47.51, 80.96);
INSERT INTO layout_items (token, weight, score, ratio) VALUES ('cached', 82.1, 90.24, 0.5);
