-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (rank, region, state) VALUES (14, 'strict', 'stable');
INSERT INTO layout_items (rank, region, state) VALUES (18, 'strict', 'legacy');
INSERT INTO layout_items (rank, region, state) VALUES (20, 'eu-west', 'strict');
