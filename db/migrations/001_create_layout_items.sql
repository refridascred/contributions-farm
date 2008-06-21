-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (region, rank, owner) VALUES ('staging', 13, 'edge');
INSERT INTO layout_items (region, rank, owner) VALUES ('open', 43, 'staging');
INSERT INTO layout_items (region, rank, owner) VALUES ('fallback', 45, 'edge');
