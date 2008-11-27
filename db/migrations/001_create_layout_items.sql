-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (count, active, weight, label, region) VALUES (58, 4, 84.91, 'staging', 'stable');
INSERT INTO layout_items (count, active, weight, label, region) VALUES (17, 22, 66.84, 'latest', 'fallback');
