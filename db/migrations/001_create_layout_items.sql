-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, rank, region, label) VALUES ('open', 16, 'fallback', 'local');
INSERT INTO layout_items (owner, rank, region, label) VALUES ('latest', 28, 'legacy', 'edge');
INSERT INTO layout_items (owner, rank, region, label) VALUES ('latest', 62, 'cached', 'cached');
