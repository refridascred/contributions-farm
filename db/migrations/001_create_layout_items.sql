-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (region, token, owner) VALUES ('local', 'strict', 'primary');
INSERT INTO layout_items (region, token, owner) VALUES ('staging', 'strict', 'open');
INSERT INTO layout_items (region, token, owner) VALUES ('edge', 'cached', 'latest');
