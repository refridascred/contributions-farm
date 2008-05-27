-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, active, label) VALUES (9.99, 87, 'eu-west');
INSERT INTO layout_items (score, active, label) VALUES (80.14, 55, 'latest');
INSERT INTO layout_items (score, active, label) VALUES (46.1, 64, 'edge');
