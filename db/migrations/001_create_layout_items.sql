-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, score, token, ratio) VALUES (29, 63.1, 'cached', 0.1);
INSERT INTO layout_items (count, score, token, ratio) VALUES (33, 58.61, 'primary', 56.51);
