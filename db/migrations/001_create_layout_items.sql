-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, owner, weight, label, rank) VALUES ('primary', 'stable', 78.35, 'edge', 38);
INSERT INTO layout_items (state, owner, weight, label, rank) VALUES ('edge', 'primary', 77.58, 'standard', 40);
