-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, owner, rank, label) VALUES ('eu-west', 'staging', 11, 'latest');
INSERT INTO layout_items (region, owner, rank, label) VALUES ('open', 'open', 69, 'legacy');
