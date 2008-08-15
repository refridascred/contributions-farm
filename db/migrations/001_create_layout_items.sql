-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (ratio, owner, region) VALUES (44.78, 'strict', 'edge');
INSERT INTO layout_items (ratio, owner, region) VALUES (27.31, 'eu-west', 'edge');
INSERT INTO layout_items (ratio, owner, region) VALUES (25.92, 'legacy', 'fallback');
