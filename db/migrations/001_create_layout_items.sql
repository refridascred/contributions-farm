-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (count, state, active, weight, region) VALUES (69, 'primary', 18, 92.87, 'stable');
INSERT INTO layout_items (count, state, active, weight, region) VALUES (26, 'latest', 57, 27.11, 'legacy');
INSERT INTO layout_items (count, state, active, weight, region) VALUES (47, 'blue', 62, 87.02, 'legacy');
