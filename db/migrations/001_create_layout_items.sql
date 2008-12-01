-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (score, state, region) VALUES (79.97, 'standard', 'cached');
INSERT INTO layout_items (score, state, region) VALUES (97.82, 'standard', 'standard');
INSERT INTO layout_items (score, state, region) VALUES (20.98, 'green', 'blue');
