-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, ratio, count, level, label) VALUES ('fallback', 77.97, 63, 56, 'edge');
INSERT INTO layout_items (owner, ratio, count, level, label) VALUES ('legacy', 12.88, 90, 2, 'legacy');
INSERT INTO layout_items (owner, ratio, count, level, label) VALUES ('standard', 13.15, 70, 50, 'stable');
