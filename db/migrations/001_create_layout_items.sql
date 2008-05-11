-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, state, region) VALUES (13.88, 'green', 'staging');
INSERT INTO layout_items (score, state, region) VALUES (34.84, 'cached', 'primary');
INSERT INTO layout_items (score, state, region) VALUES (8.68, 'open', 'staging');
