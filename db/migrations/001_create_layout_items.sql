-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, rank, owner) VALUES (25.61, 25, 'edge');
INSERT INTO layout_items (ratio, rank, owner) VALUES (71.77, 65, 'local');
INSERT INTO layout_items (ratio, rank, owner) VALUES (77.35, 61, 'cached');
