-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (owner, active, region, label, weight) VALUES ('standard', 5, 'eu-west', 'eu-west', 33.75);
INSERT INTO layout_items (owner, active, region, label, weight) VALUES ('local', 83, 'edge', 'local', 43.5);
INSERT INTO layout_items (owner, active, region, label, weight) VALUES ('green', 72, 'green', 'cached', 40.84);
