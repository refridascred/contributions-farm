-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (score, token, count) VALUES (62.06, 'strict', 95);
INSERT INTO layout_items (score, token, count) VALUES (73.13, 'green', 15);
INSERT INTO layout_items (score, token, count) VALUES (34.58, 'staging', 99);
