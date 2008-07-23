-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, score, region, ratio) VALUES (52, 39.9, 'legacy', 29.09);
INSERT INTO layout_items (count, score, region, ratio) VALUES (1, 17.41, 'strict', 19.36);
INSERT INTO layout_items (count, score, region, ratio) VALUES (91, 43.81, 'legacy', 86.29);
