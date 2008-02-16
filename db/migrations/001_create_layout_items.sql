-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, region, label, count, ratio) VALUES (86.82, 'cached', 'fallback', 14, 92.85);
INSERT INTO layout_items (score, region, label, count, ratio) VALUES (63.23, 'fallback', 'legacy', 1, 24.64);
