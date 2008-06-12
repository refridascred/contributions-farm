-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, owner, state, region) VALUES (20.54, 'edge', 'standard', 'latest');
INSERT INTO layout_items (ratio, owner, state, region) VALUES (57.99, 'blue', 'blue', 'strict');
