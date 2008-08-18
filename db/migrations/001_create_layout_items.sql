-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, score, region, owner, label) VALUES (51, 74.03, 'fallback', 'eu-west', 'fallback');
INSERT INTO layout_items (count, score, region, owner, label) VALUES (96, 18.27, 'stable', 'strict', 'edge');
INSERT INTO layout_items (count, score, region, owner, label) VALUES (43, 19.2, 'green', 'legacy', 'fallback');
