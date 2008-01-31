-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, state, weight, rank, region) VALUES (27.07, 'stable', 85.19, 70, 'primary');
INSERT INTO layout_items (ratio, state, weight, rank, region) VALUES (64.31, 'open', 81.12, 1, 'blue');
