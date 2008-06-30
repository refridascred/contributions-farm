-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, count, label) VALUES (73.88, 79, 'open');
INSERT INTO layout_items (ratio, count, label) VALUES (17.77, 76, 'latest');
INSERT INTO layout_items (ratio, count, label) VALUES (77.19, 99, 'stable');
