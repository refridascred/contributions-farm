-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, region, state, label) VALUES (8.88, 'local', 'eu-west', 'standard');
INSERT INTO layout_items (weight, region, state, label) VALUES (68.68, 'edge', 'green', 'edge');
INSERT INTO layout_items (weight, region, state, label) VALUES (9.41, 'strict', 'strict', 'local');
