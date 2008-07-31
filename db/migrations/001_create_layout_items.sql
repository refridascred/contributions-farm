-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (active, ratio, label) VALUES (37, 53.05, 'cached');
INSERT INTO layout_items (active, ratio, label) VALUES (61, 85.13, 'cached');
