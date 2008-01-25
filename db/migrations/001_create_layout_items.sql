-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, weight, active, region) VALUES ('cached', 53.04, 72, 'latest');
INSERT INTO layout_items (label, weight, active, region) VALUES ('edge', 56.64, 65, 'staging');
