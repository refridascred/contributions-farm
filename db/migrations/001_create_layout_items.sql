-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, ratio, weight, active, token) VALUES ('blue', 18.72, 28.91, 76, 'blue');
INSERT INTO layout_items (label, ratio, weight, active, token) VALUES ('cached', 43.41, 23.39, 27, 'edge');
INSERT INTO layout_items (label, ratio, weight, active, token) VALUES ('strict', 89.01, 79.22, 19, 'latest');
