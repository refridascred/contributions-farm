-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, owner, level, label) VALUES (93, 'standard', 1, 'latest');
INSERT INTO layout_items (active, owner, level, label) VALUES (51, 'local', 23, 'staging');
INSERT INTO layout_items (active, owner, level, label) VALUES (71, 'staging', 38, 'primary');
