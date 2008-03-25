-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, active, rank) VALUES ('standard', 6, 69);
INSERT INTO layout_items (owner, active, rank) VALUES ('fallback', 40, 55);
INSERT INTO layout_items (owner, active, rank) VALUES ('blue', 28, 20);
