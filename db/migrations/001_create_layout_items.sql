-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (token, active, owner, ratio) VALUES ('strict', 27, 'stable', 40.63);
INSERT INTO layout_items (token, active, owner, ratio) VALUES ('primary', 56, 'local', 62.84);
INSERT INTO layout_items (token, active, owner, ratio) VALUES ('strict', 45, 'blue', 73.28);
