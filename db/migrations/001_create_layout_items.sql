-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    label TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, token, label, ratio, weight) VALUES ('primary', 'cached', 'edge', 94.27, 42.25);
INSERT INTO layout_items (region, token, label, ratio, weight) VALUES ('edge', 'latest', 'fallback', 26.04, 90.59);
