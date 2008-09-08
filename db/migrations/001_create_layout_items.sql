-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (active, count, weight, label) VALUES (4, 82, 84.56, 'latest');
INSERT INTO layout_items (active, count, weight, label) VALUES (97, 17, 95.91, 'standard');
INSERT INTO layout_items (active, count, weight, label) VALUES (29, 91, 75.85, 'staging');
