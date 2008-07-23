-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (rank, region) VALUES (49, 'legacy');
INSERT INTO layout_items (rank, region) VALUES (43, 'open');
INSERT INTO layout_items (rank, region) VALUES (92, 'cached');
