-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, owner, level) VALUES (88, 'eu-west', 9);
INSERT INTO layout_items (rank, owner, level) VALUES (38, 'fallback', 52);
INSERT INTO layout_items (rank, owner, level) VALUES (68, 'standard', 15);
