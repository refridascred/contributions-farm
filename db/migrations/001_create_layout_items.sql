-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, active, ratio) VALUES ('green', 17, 57.36);
INSERT INTO layout_items (token, active, ratio) VALUES ('open', 48, 14.78);
INSERT INTO layout_items (token, active, ratio) VALUES ('staging', 28, 14.99);
