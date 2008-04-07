-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, region, level, label) VALUES (42.24, 'edge', 19, 'legacy');
INSERT INTO layout_items (ratio, region, level, label) VALUES (35.45, 'staging', 86, 'stable');
INSERT INTO layout_items (ratio, region, level, label) VALUES (75.12, 'local', 95, 'fallback');
