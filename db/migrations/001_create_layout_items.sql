-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (active, state, label, weight) VALUES (80, 'eu-west', 'edge', 0.01);
INSERT INTO layout_items (active, state, label, weight) VALUES (25, 'staging', 'blue', 33.46);
INSERT INTO layout_items (active, state, label, weight) VALUES (38, 'blue', 'eu-west', 83.36);
