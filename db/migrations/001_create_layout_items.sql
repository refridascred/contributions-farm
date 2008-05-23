-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (owner, state, rank, region) VALUES ('edge', 'local', 62, 'green');
INSERT INTO layout_items (owner, state, rank, region) VALUES ('primary', 'strict', 61, 'latest');
