-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, label, region) VALUES (85.32, 'primary', 'open');
INSERT INTO layout_items (ratio, label, region) VALUES (61.42, 'open', 'blue');
INSERT INTO layout_items (ratio, label, region) VALUES (78.89, 'blue', 'blue');
