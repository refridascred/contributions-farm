-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, count, level, label) VALUES (98.91, 77, 1, 'blue');
INSERT INTO layout_items (ratio, count, level, label) VALUES (31.79, 8, 72, 'latest');
INSERT INTO layout_items (ratio, count, level, label) VALUES (0.34, 86, 14, 'primary');
