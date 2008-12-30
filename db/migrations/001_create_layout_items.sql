-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, label, ratio, token) VALUES (81, 'eu-west', 56.91, 'local');
INSERT INTO layout_items (count, label, ratio, token) VALUES (47, 'green', 40.42, 'green');
INSERT INTO layout_items (count, label, ratio, token) VALUES (62, 'edge', 82.36, 'blue');
