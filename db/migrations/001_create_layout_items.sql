-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (owner, label, weight, token) VALUES ('eu-west', 'edge', 13.13, 'latest');
INSERT INTO layout_items (owner, label, weight, token) VALUES ('cached', 'strict', 4.21, 'latest');
