-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (score, owner, region) VALUES (40.8, 'standard', 'primary');
INSERT INTO layout_items (score, owner, region) VALUES (66.04, 'primary', 'staging');
