-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (rank, label, owner, region) VALUES (97, 'blue', 'cached', 'fallback');
INSERT INTO layout_items (rank, label, owner, region) VALUES (23, 'open', 'blue', 'latest');
INSERT INTO layout_items (rank, label, owner, region) VALUES (12, 'blue', 'open', 'green');
