-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (owner, level, region, active) VALUES ('standard', 5, 'cached', 11);
INSERT INTO layout_items (owner, level, region, active) VALUES ('eu-west', 15, 'open', 44);
