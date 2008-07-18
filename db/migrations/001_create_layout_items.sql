-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, label, region) VALUES (13.73, 'open', 'green');
INSERT INTO layout_items (ratio, label, region) VALUES (36.03, 'legacy', 'latest');
