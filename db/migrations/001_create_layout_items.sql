-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, rank, weight, ratio, region) VALUES ('edge', 11, 42.08, 57.65, 'eu-west');
INSERT INTO layout_items (state, rank, weight, ratio, region) VALUES ('edge', 43, 35.05, 42.93, 'legacy');
