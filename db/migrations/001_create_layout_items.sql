-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (rank, label, owner, region) VALUES (92, 'fallback', 'edge', 'primary');
INSERT INTO layout_items (rank, label, owner, region) VALUES (46, 'legacy', 'standard', 'standard');
INSERT INTO layout_items (rank, label, owner, region) VALUES (42, 'legacy', 'cached', 'open');
