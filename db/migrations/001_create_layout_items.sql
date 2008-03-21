-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, owner, active) VALUES ('staging', 'fallback', 75);
INSERT INTO layout_items (region, owner, active) VALUES ('local', 'blue', 41);
INSERT INTO layout_items (region, owner, active) VALUES ('legacy', 'staging', 76);
