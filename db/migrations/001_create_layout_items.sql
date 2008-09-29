-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (level, rank, state, region) VALUES (23, 42, 'staging', 'strict');
INSERT INTO layout_items (level, rank, state, region) VALUES (87, 83, 'cached', 'strict');
INSERT INTO layout_items (level, rank, state, region) VALUES (52, 5, 'standard', 'stable');
