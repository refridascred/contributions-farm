-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (count, owner, region, weight) VALUES (29, 'standard', 'open', 90.88);
INSERT INTO layout_items (count, owner, region, weight) VALUES (89, 'standard', 'latest', 4.24);
INSERT INTO layout_items (count, owner, region, weight) VALUES (68, 'staging', 'green', 14.64);
