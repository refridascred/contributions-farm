-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, ratio, owner, level, label) VALUES (43, 42.75, 'staging', 38, 'latest');
INSERT INTO layout_items (count, ratio, owner, level, label) VALUES (63, 35.21, 'edge', 71, 'legacy');
