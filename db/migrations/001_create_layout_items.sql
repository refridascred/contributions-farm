-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (token, level, owner, state) VALUES ('primary', 44, 'eu-west', 'local');
INSERT INTO layout_items (token, level, owner, state) VALUES ('eu-west', 70, 'blue', 'blue');
INSERT INTO layout_items (token, level, owner, state) VALUES ('strict', 61, 'staging', 'staging');
