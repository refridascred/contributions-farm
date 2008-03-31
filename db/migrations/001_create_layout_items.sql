-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (region, active, owner, level) VALUES ('primary', 47, 'edge', 80);
INSERT INTO layout_items (region, active, owner, level) VALUES ('local', 93, 'eu-west', 41);
