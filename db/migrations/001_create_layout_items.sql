-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, state, weight, owner) VALUES (30, 'open', 2.07, 'standard');
INSERT INTO layout_items (level, state, weight, owner) VALUES (94, 'blue', 66.13, 'blue');
INSERT INTO layout_items (level, state, weight, owner) VALUES (20, 'legacy', 84.41, 'edge');
