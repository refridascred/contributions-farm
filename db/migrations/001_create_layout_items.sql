-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (token, level, owner) VALUES ('standard', 8, 'standard');
INSERT INTO layout_items (token, level, owner) VALUES ('strict', 7, 'eu-west');
