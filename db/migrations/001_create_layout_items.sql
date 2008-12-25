-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    level INTEGER,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, region, level, rank, state) VALUES (42.28, 'eu-west', 4, 53, 'edge');
INSERT INTO layout_items (weight, region, level, rank, state) VALUES (78.86, 'stable', 90, 44, 'standard');
INSERT INTO layout_items (weight, region, level, rank, state) VALUES (15.55, 'staging', 62, 47, 'eu-west');
