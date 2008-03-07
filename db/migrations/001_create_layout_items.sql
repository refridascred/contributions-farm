-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (active, owner, weight) VALUES (77, 'staging', 32.58);
INSERT INTO layout_items (active, owner, weight) VALUES (16, 'standard', 63.65);
INSERT INTO layout_items (active, owner, weight) VALUES (32, 'open', 66.53);
