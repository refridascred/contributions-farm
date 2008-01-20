-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, weight, region) VALUES ('primary', 69.33, 'stable');
INSERT INTO layout_items (label, weight, region) VALUES ('eu-west', 12.19, 'blue');
INSERT INTO layout_items (label, weight, region) VALUES ('open', 46.6, 'open');
