-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, state, weight) VALUES (58, 'standard', 93.22);
INSERT INTO layout_items (level, state, weight) VALUES (12, 'green', 71.86);
INSERT INTO layout_items (level, state, weight) VALUES (88, 'standard', 42.74);
