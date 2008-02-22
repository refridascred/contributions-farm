-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, score, state, region) VALUES ('edge', 7.57, 'standard', 'staging');
INSERT INTO layout_items (owner, score, state, region) VALUES ('blue', 63.55, 'primary', 'staging');
