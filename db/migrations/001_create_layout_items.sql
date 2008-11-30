-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, count, token, score) VALUES ('green', 73, 'stable', 20.45);
INSERT INTO layout_items (region, count, token, score) VALUES ('open', 84, 'stable', 7.06);
INSERT INTO layout_items (region, count, token, score) VALUES ('edge', 70, 'fallback', 94.65);
